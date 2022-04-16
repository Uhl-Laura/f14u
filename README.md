# f1-admin-app

Backend set-up: 

Download MongoDB:
https://www.mongodb.com/try/download/community

Download complete pack (the recommended one)

Enter MongoDB Compass and click connect

Create a new database called “f14u” with a collection (similar to MySQL table) called “Credentials”

Insert some basic data into the Credentials collection. You can do that by clicking on "Insert Document" in MongoDB Compass.
For the initial set-up to work, the data in Credentials collection should have the following structure: 
    {
        "id": "625a7e89d33edf95d3e09822",
        "username": "test",
        "name": "testpass"
    }
The id is automatically generated, so leave it default.


Get it to work: 

Download Postman
Create new request with the url: http://localhost:5000/credentials 
Run the backend
Send the request and you should get your data from the db as a response.
