param(
    [string] $PublishRoot = (Join-Path (Split-Path -Parent $PSScriptRoot) "publish"),
    [string] $Prefix = "AngryBirds_",
    [switch] $Force
)

$ErrorActionPreference = "Stop"

if (-not (Test-Path $PublishRoot)) {
    throw "Publish root not found: $PublishRoot"
}

$rids = @("win-x64", "win-x86", "win-arm64", "win-arm")

foreach ($rid in $rids) {
    $source = Join-Path $PublishRoot "$Prefix$rid"
    if (-not (Test-Path $source)) {
        Write-Host "Skipping $rid - folder not found: $source"
        continue
    }

    $zipPath = Join-Path $PublishRoot "$Prefix$rid.zip"

    if ((Test-Path $zipPath) -and -not $Force) {
        Write-Host "Skipping $rid - archive already exists: $zipPath"
        Write-Host "  (use -Force to overwrite)"
        continue
    }

    if ((Test-Path $zipPath)) {
        Remove-Item -LiteralPath $zipPath -Force
    }

    Write-Host "Compressing $source -> $zipPath"

    # Compress-Archive writes a deterministic zip file directly to disk.
    # We use -Path $source so the zip contains a top-level folder, e.g.
    # AngryBirds_win-x64\AngryBirds.exe, AngryBirds_win-x64\Start-Game.bat, ...
    Compress-Archive -Path $source -DestinationPath $zipPath -CompressionLevel Optimal

    $size = (Get-Item $zipPath).Length
    $human = "{0:N1} MB" -f ($size / 1MB)
    Write-Host "  Done: $zipPath ($human)"
}

Write-Host ""
Write-Host "Zip archives created in: $PublishRoot"
