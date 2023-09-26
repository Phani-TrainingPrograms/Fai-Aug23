# Commands to execute for Packages
- install-package Microsoft.EntityFrameworkCore
- install-package Microsoft.EntityFrameworkCore.Tools
- install-package Microsoft.EntityFrameworkCore.SqlServer


## Commands for Table creation
- add-migration initial
- update-database
- initial is the name you give for the migration file. It can be any other name. 
- add-migration should be called after the model, dbcontext and the DI code for DBContext class in the program is created. 
