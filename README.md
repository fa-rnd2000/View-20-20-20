It is a simple Timer to remind PC users to view any object 20 feet away for 20 seconds every 20 minutes. It helps relax eye muscles and improve vision.

HOW TO RUN THIS APP ON WINDOWS STARTUP:

To run your VB.NET application on startup in Windows 10, you can add an entry to the Windows Registry. Here are the steps:

Create a Shortcut for your VB.NET Application:

Right-click on your VB.NET application's executable file (.exe) and choose "Create Shortcut."
Move the shortcut to a convenient location.
Open the Run Dialog:

Press Win + R to open the Run dialog.
Type "shell:startup" and Press Enter:

Type shell:startup in the Run dialog and press Enter. This will open the Startup folder.
Copy the Shortcut:

Copy the shortcut you created in step 1.
Paste the Shortcut into the Startup Folder:

Paste the shortcut into the Startup folder. This will ensure that your application runs every time the user logs in.
Now, your VB.NET application should start automatically when the user logs into Windows.

Alternatively, you can use the Windows Task Scheduler to achieve the same result. Here's how:

Open Task Scheduler:

Press Win + S, type "Task Scheduler," and open the Task Scheduler application.
Create a Basic Task:

In the Actions pane, click on "Create Basic Task."
Follow the Wizard:

Follow the steps in the wizard to give your task a name and description.
Select "When I log on":

Choose the option "When I log on" as the trigger for the task.
Select the Program/Script:

Choose "Start a program" as the action, and then browse and select the executable file of your VB.NET application.
Complete the Wizard:

Complete the wizard by following the remaining steps.
