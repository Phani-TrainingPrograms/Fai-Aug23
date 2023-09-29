# REST API Development
- JSON-SERVER is used for creating quick REST End points for testing Front end apps like React, Angular, jQuery, Vue.js Apps. 
- It is available as an NPM Package.

## Steps to create the server
1. Create a new folder in UR Machine and name it appropriately
2. Create a sample package.json file using the command 
```
npm init -y
```
3. Install the json-server package in ur folder
```
npm install json-server
```
4. Create a file called db.json and create a sample json data as per your business requirement. The file is shared in the Repo. 
5. Update the package.json with the following lines
```
{
  "name": "json-server-api",
  "version": "1.0.0",
  "description": "",
  "main": "index.js",
  "scripts": {
    "start" : "json-server --watch db.json --port 1234"
  },
  "keywords": [],
  "author": "",
  "license": "ISC",
  "dependencies": {
    "json-server": "^0.17.3"
  }
}
```
6. From the Folder terminal, run the following command to start the server
```
npm start
```