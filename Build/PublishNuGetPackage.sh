VersionNumber="$VersionNumberPrefix.${TRAVIS_BUILD_NUMBER}"

echo "VersionNumber: $VersionNumber"

if [ "$TRAVIS_BRANCH" == "master" ]; then	
	mkdir Src/Nuget/Packages

	mono --runtime=v4.0.30319 Src/.nuget/NuGet.exe Pack Src/Nuget/Nlog.HipChat/NLog.HipChat.nuspec -NonInteractive -OutputDirectory Src/Nuget/Packages
fi
