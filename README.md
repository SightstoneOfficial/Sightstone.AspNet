# Sightstone.AspNet
The official sightstone website

Connect to league of legends, launch your game and play your way. No need to use the client. Requires league of legends to be installed and up to date.

Join the chat <a href="https://discord.gg/Av4FQEF">here</a>.

# Security
If you do not think our server is secure enough, you are free to use the source code for your own server. If you do this, you are not allowed to post the url to your website anywhere.

The source code is changed when pushed to the server. This is because we do not want to compromise the database containing all the login information. The only things that is changed will be     
```html 
<add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-Sightstone.AspNet-20160827065244.mdf;Initial Catalog=aspnet-Sightstone.AspNet-20160827065244;Integrated Security=True" providerName="System.Data.SqlClient" />
```
in the Web.Config file and the
```cs
public ApplicationDbContext() : base("DefaultConnection", false)
```
in the IdentityModels class and an encryption class will be added but not shown to make it more difficult for users who manage to access the database from getting any accounts. Please understand that this is only done for privacy reasons.

Please note that after account creation you will not be able to read your account login credentials on the website. You can update these credentials or remove them; however, these credentials can not be retreived and displayed.

# Launching the game
You will not need any special programs to start the client. When the game starts a .bat file will be downloaded to your computer. Launch this file to start the game. You must install league of legends and keep it up to date before entering a game.

# Screen shots
This screen shots are work in progress. They may change anytime for any reason.

Please note that I am not a gui designer. The UI will not be the nicest while in development.
![Index](http://i.imgur.com/1XvmBlq.png)
![About](http://i.imgur.com/krhw3hK.png)


