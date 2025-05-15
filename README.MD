# Thông Tin
- Project Dùng phiên bản .NET SDK 6.0, để chạy dự án Vui lòng tải phiên bản .net6.0 :Tải bản cho => windown <a href="https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.428-windows-x64-installer">TẢI</a>
## Tải xong Chạy lệnh
```PowerShell
dotnet clean
dotnet restore
dotnet run
```
## Sau khi Clone dự án Vui lòng tạo Branch mới cho mỗi thành viên
## Danh sách thư viện cần cài đặt
```PowerShell
dotnet tool install --global dotnet-ef --version 6.0.25
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.36
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.28
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.36
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.3
dotnet add package Microsoft.Extensions.DependencyInjection --version 6.0.2
dotnet add package Microsoft.Extensions.Logging.Console --version 6.0.0
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.2
dotnet add package System.Data.SqlClient --version 4.9.0
dotnet add package Microsoft.Extensions.Configuration.Json
```
