param(
    [Parameter(Mandatory = $true)]
    [string] $PngPath,

    [Parameter(Mandatory = $true)]
    [string] $IcoPath,

    [int[]] $Sizes = @(16, 32, 48, 64, 128, 256)
)

$ErrorActionPreference = "Stop"

if (-not (Test-Path $PngPath)) {
    throw "PNG not found: $PngPath"
}

Add-Type -AssemblyName System.Drawing

$src = [System.Drawing.Image]::FromFile((Resolve-Path $PngPath).Path)

# Render each requested size into a 32bpp ARGB bitmap so alpha is preserved.
$pngStreams = @()
foreach ($s in $Sizes) {
    $bmp = New-Object System.Drawing.Bitmap($s, $s, [System.Drawing.Imaging.PixelFormat]::Format32bppArgb)
    $g = [System.Drawing.Graphics]::FromImage($bmp)
    $g.InterpolationMode = [System.Drawing.Drawing2D.InterpolationMode]::HighQualityBicubic
    $g.SmoothingMode = [System.Drawing.Drawing2D.SmoothingMode]::HighQuality
    $g.PixelOffsetMode = [System.Drawing.Drawing2D.PixelOffsetMode]::HighQuality
    $g.DrawImage($src, 0, 0, $s, $s)
    $g.Dispose()

    $ms = New-Object System.IO.MemoryStream
    $bmp.Save($ms, [System.Drawing.Imaging.ImageFormat]::Png)
    $bmp.Dispose()
    $pngStreams += , @{ Size = $s; Bytes = $ms.ToArray() }
    $ms.Dispose()
}
$src.Dispose()

# Build ICO file: ICONDIR + N*ICONDIRENTRY + N*PNG payloads (Vista+ supports PNG-in-ICO).
$fs = [System.IO.File]::Create($IcoPath)
try {
    $bw = New-Object System.IO.BinaryWriter($fs)

    # ICONDIR (6 bytes)
    $bw.Write([UInt16]0)              # reserved
    $bw.Write([UInt16]1)              # type = icon
    $bw.Write([UInt16]$pngStreams.Count)

    # ICONDIRENTRY (16 bytes each)
    $offset = 6 + 16 * $pngStreams.Count
    foreach ($entry in $pngStreams) {
        $w = if ($entry.Size -ge 256) { 0 } else { [byte]$entry.Size }   # 0 means 256
        $h = $w
        $bw.Write([byte]$w)            # width
        $bw.Write([byte]$h)            # height
        $bw.Write([byte]0)             # color count
        $bw.Write([byte]0)             # reserved
        $bw.Write([UInt16]1)           # color planes
        $bw.Write([UInt16]32)          # bits per pixel
        $bw.Write([UInt32]$entry.Bytes.Length)  # bytes in resource
        $bw.Write([UInt32]$offset)     # image offset
        $offset += $entry.Bytes.Length
    }

    # PNG payloads
    foreach ($entry in $pngStreams) {
        $bw.Write($entry.Bytes)
    }
} finally {
    $bw.Flush()
    $fs.Flush()
    $fs.Close()
}

Write-Host ("Wrote {0} ({1} bytes, sizes: {2})" -f $IcoPath, (Get-Item $IcoPath).Length, ($Sizes -join ","))
