param([string]$ProjectConfig, [string]$VersionConfig);

$currentTime = Get-Date -Format yyyy.MM.dd.HHmm;
$find = "<Version>(.|\n)*?</Version>";
$replace = "<Version>" + $currentTime + "</Version>";
$csproj = Get-Content $ProjectConfig
$csprojUpdated = $csproj -Replace $find, $replace

Set-Content -Path $ProjectConfig -Value $csprojUpdated

return $currentTime