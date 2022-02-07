1. Go to https://github.com/alfredoiv/123Pay.git
2. Download "123Pay-master.zip"
3. Move "123Pay-master.zip" to "C:/Projects/" to avoid conflicts
4. Extract "123Pay-master.zip"
5. Open "123Pay" Folder then double-click "123Pay.sln" to open the solution.
6. In the Solution Explorer, open "appsettings.json"
7. In "123PayDbConnection" connectionStrings, change the text "MAGPANTAYIV\\SQLSERVER" to your valid MS SQL Server Name.
8. Save the file.
9. Then Build the project (Ctrl+Shift+B)
10. Go to Package Manager Console:
		Tools > Nuget Package Manager > Package Manager Console
11. Click on the Package Manager Console window
12. Type "Enable-Migrations" then press Enter
13. Type "Add-Migration Initialize" then press Enter
14. Type "Update-Database" then press Enter
15. In your MS SQL Server, please check if 123Pay database is created.
16. You may also check the tables with names beginning with "AspNet", these tables are created from Microsoft.AspNetCore.Identity.EntityFrameworkCore (built-in tables)
17. Please also check the data in tables "PaymentRequests" & "AspNetUsers" which are seeded in modelBuilder.
18. You can also login to view the list of Payment Requests which is only available to administrator user. 
			Here are the credentials: 
					Username: administrator
					Password: test123

Please enjoy and validate my technical examination, I hope I have fulfilled all of the requirements carefully.

If you have any concerns & clarifications, 
Please feel free to contact me via email: alfredoiv.magpantay@yahoo.com
							or via phone: 09994855182
