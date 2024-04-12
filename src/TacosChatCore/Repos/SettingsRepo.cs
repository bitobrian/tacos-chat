﻿using LiteDB;
using TacosChatCore.Models;
using TacosChatCore.Services;

namespace TacosChatCore.Repos;

public class SettingsRepo
{
    private const string SettingsCollectionName = "settings";
    private readonly string _dbPath;

    public SettingsRepo(IDeviceStorage deviceStorage)
    {
        var savePath = deviceStorage.GetSaveFolderPath();
        _dbPath = Path.Combine(savePath, "TacosChat.db");
    }

    public void SaveSetting(string profileKey, Settings newSettings)
    {
        using var db = new LiteDatabase(_dbPath);
        
        var settings = db.GetCollection<Settings>(SettingsCollectionName);
        
        settings.Upsert(profileKey, newSettings);
    }

    public Settings GetSettings(string profileKey)
    {
        using var db = new LiteDatabase(_dbPath);
        
        var settings = db.GetCollection<Settings>(SettingsCollectionName);
        
        var setting = settings.FindById(profileKey);
        
        return setting;
    }
}
