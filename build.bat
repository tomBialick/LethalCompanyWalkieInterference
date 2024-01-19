dotnet build %~dp0WalkieInterference.csproj
powershell -Command Copy-Item -Force -Path "%~dp0bin\Debug\netstandard2.1\WalkieInterference.dll" -Destination "%~dp0thunderstore\WalkieInterference.dll"
powershell -Command Copy-Item -Force -Path "%~dp0bin\Debug\netstandard2.1\WalkieInterference.dll" -Destination """D:\SteamLibrary\steamapps\common\Lethal Company\BepInEx\plugins\WalkieInterference.dll"""
Start-Process & "D:\SteamLibrary\steamapps\common\Lethal Company\Lethal Company.exe"