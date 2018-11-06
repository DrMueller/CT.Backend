$filePath= Join-Path -Path $(Build.Repository.LocalPath) -ChildPath "\docker-stack.yml"

$environmentContent = Get-Content $filePath
$replaced = $environmentContent -replace '__ImageName__', '$(Build.Repository.Name):$(Build.BuildNumber)'

Set-Content -Path $filePath -value $replaced
