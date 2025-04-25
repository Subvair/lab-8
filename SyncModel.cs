using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectorySyncMVP
{
  public class SyncModel
  {
    public List<string> SyncDirectories(string directory1Path, string directory2Path, out List<string> log)
    {
      log = new List<string>();

      SyncOneWay(directory1Path, directory2Path, log);
      SyncOneWay(directory2Path, directory1Path, log);

      return log;
    }

    private void SyncOneWay(string sourceDirectory, string targetDirectory, List<string> log)
    {
      var sourceFiles = Directory.GetFiles(sourceDirectory, "*", SearchOption.AllDirectories)
                                 .Select(file => file.Substring(sourceDirectory.Length + 1))
                                 .ToHashSet();

      var targetFiles = Directory.GetFiles(targetDirectory, "*", SearchOption.AllDirectories)
                                 .Select(file => file.Substring(targetDirectory.Length + 1))
                                 .ToHashSet();

      foreach (var relativePath in sourceFiles)
      {
        var sourceFilePath = Path.Combine(sourceDirectory, relativePath);
        var targetFilePath = Path.Combine(targetDirectory, relativePath);

        if (!File.Exists(targetFilePath))
        {
          Directory.CreateDirectory(Path.GetDirectoryName(targetFilePath));
          File.Copy(sourceFilePath, targetFilePath, true);
          log.Add($"Файл \"{relativePath}\" создан");
        }
        else if (File.GetLastWriteTime(sourceFilePath) > File.GetLastWriteTime(targetFilePath))
        {
          File.Copy(sourceFilePath, targetFilePath, true);
          log.Add($"Файл \"{relativePath}\" изменен");
        }
      }

      foreach (var relativePath in targetFiles.Except(sourceFiles))
      {
        var targetFilePath = Path.Combine(targetDirectory, relativePath);
        File.Delete(targetFilePath);
        log.Add($"Файл \"{relativePath}\" удален");
      }
    }
  }
}
