## my first utilization of ADO.NET technology
I used ADO.NET to connect my WinForms application to a database of student records. The goal of the project was to create a user-friendly application that allowed users to view, edit, and delete student records in the database.

To achieve this, I used disconnected mode to retrieve the student data from the database and populate the table in the user interface. When the user opened the application, the data was loaded from the database into a DataTable object, which was then used to populate the DataGridView control in the UI. By using disconnected mode, the application was able to display the data efficiently and without the need for a continuous connection to the database.

To add, update, or delete a student record, I used connected mode to execute SQL commands against the database. Whenever a user made a change to a cell in the DataGridView control, the application used a SqlCommand object to update the corresponding record in the database. Similarly, when the user selected a row and clicked the "Delete" button, the application used SqlCommand objects to delete the selected student record from the database.
