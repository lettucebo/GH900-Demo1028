# .NET 9 教學範例網站

這是一個使用 .NET 9 和 ASP.NET Core Razor Pages 建立的教學範例網站。

## 🎯 專案特色

- 使用最新的 .NET 9 框架
- ASP.NET Core Razor Pages 實作
- Bootstrap 5 響應式設計
- 繁體中文介面
- 包含多個實用的程式碼範例

## 📋 系統需求

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) 或更高版本

## 🚀 快速開始

### 1. 複製專案

```bash
git clone https://github.com/lettucebo/GH900-Demo1028.git
cd GH900-Demo1028/TutorialWebApp
```

### 2. 還原套件

```bash
dotnet restore
```

### 3. 建置專案

```bash
dotnet build
```

### 4. 執行應用程式

```bash
dotnet run
```

應用程式將會在 `http://localhost:5000` 上啟動（或顯示在終端機中的其他埠號）。

## 📚 網站內容

### 首頁
- 介紹 .NET 9 的主要功能
- Razor Pages 概述
- 程式碼範例連結

### 程式碼範例頁面
包含多個實用的範例：
1. 顯示當前時間
2. 隨機數字產生器
3. 迴圈與集合資料處理
4. 條件式渲染
5. 環境資訊顯示

### 關於頁面
- 技術堆疊說明
- 學習目標
- 相關資源連結

## 🛠️ 專案結構

```
TutorialWebApp/
├── Pages/              # Razor Pages
│   ├── Index.cshtml    # 首頁
│   ├── Examples.cshtml # 範例頁面
│   ├── Privacy.cshtml  # 關於頁面
│   └── Shared/         # 共用佈局
├── wwwroot/            # 靜態檔案
├── Program.cs          # 應用程式進入點
└── appsettings.json    # 設定檔
```

## 🎓 學習資源

- [.NET 9 官方文件](https://learn.microsoft.com/zh-tw/dotnet/core/whats-new/dotnet-9/overview)
- [ASP.NET Core 文件](https://learn.microsoft.com/zh-tw/aspnet/core/)
- [Razor Pages 教學](https://learn.microsoft.com/zh-tw/aspnet/core/razor-pages/)

## 📝 授權

本專案採用 MIT 授權條款。