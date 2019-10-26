# webweb
A content management system that gives you control over the HTML. It features a full browser-based code editor (using Monaco), a page template system, a file management page, and a custom markup syntax to make writing pages easier and faster.
## Install guide
1. Clone the repository to your computer.
2. Edit the `appsettings.json` file located in the `webweb` folder to configure the app. You can either use the local database or modify the connection string to use another database, but it must be SQLite.
3. Follow [Microsoft's guide](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-2.2) to deploy the app.
4. On your first time running the app, use debug mode (`dotnet run` in the webweb directory) so that you can see the message for step 7. 
5. If you would like, increase the Nginx file upload size limit to 30M (the default ASP.NET Core size) by following [this guide](https://www.cyberciti.biz/faq/linux-unix-bsd-nginx-413-request-entity-too-large/).
6. Open your website in a web browser.
7. There will be an error screen, with a button to "Apply Migrations". Click it, and when it tells you to, refresh the page.
8. Fill out the form to create your admin account. If the page doesn't redirect you to /ViewPage within a few seconds, click the "Home" button on the navigation bar.

If you want to add more users, click on the wrench icon in the upper right corner, and click "Control Panel". Then, type in the email address of the account you want to register and click the "Register" button. They will get an email with a link to go to the register page. 
## Known bugs
Webweb is still in beta, so check the issues tab before deploying it to your server. 
