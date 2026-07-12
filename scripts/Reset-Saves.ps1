$SaveRoot = Join-Path ([Environment]::GetFolderPath([Environment+SpecialFolder]::LocalApplicationData)) "AngryBirds"
if (Test-Path $SaveRoot) {
    Remove-Item -LiteralPath $SaveRoot -Recurse -Force
    Write-Host "Removed saves: $SaveRoot"
}
else {
    Write-Host "No saves found: $SaveRoot"
}
