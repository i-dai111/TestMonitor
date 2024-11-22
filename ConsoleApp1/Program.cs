using System;
using System.Reflection;
using Xunit;

class Program
{
    static void Main()
    {
        // Assemblyからバージョン情報を取得
        var version = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

        Console.WriteLine($"アプリケーションのバージョン: {version}");
    }
}

public class VersionInfoTests
{
    [Fact]
    public void VersionInformation_ShouldContainGitCommitHash()
    {
        // Arrange
        var version = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

        // Act & Assert
        Assert.False(string.IsNullOrEmpty(version), "バージョン情報が取得できませんでした。");
        Assert.Matches(@"^1\.0\.0\+\w+$", version); // 1.0.0+コミットハッシュの形式を確認
    }
}
