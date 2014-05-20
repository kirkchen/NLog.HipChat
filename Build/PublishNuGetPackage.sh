VersionNumber="$VersionNumberPrefix.${TRAVIS_BUILD_NUMBER}"

echo "VersionNumber: $VersionNumber"

if [ "$TRAVIS_BRANCH" == "master" ]; then		
	mono --runtime=v4.0.30319 Src/.nuget/NuGet.exe Pack NLog.HipChat.nuspec -NonInteractive -Version ${VersionNumber}
	mono --runtime=v4.0.30319 Src/.nuget/NuGet.exe Push NLog.HipChat.${VersionNumber}.nupkg $NUGET_APIKEY -NonInteractive	
fi
