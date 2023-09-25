# Angular 
- Angular is a framework for developing UI Applications, developed by Google. 
- Angular gets a new version for every 6 months with updates and backward compatibility for the existing Applications. 
- U can use Angular CLI for creating Angular Apps using templates. 
- For developing the Apps, U need the following software
    - Nodejs
    - Angular CLI which is the CLI for developing Angular Apps

## Commands to create Angular App
1. npm install -g @angular/cli
2. ng new appname
3. cd appname
4. ng serve --open

## Features of Angular
1. Angular provides Component architecture for developing UI Features for the Application. It means that UR App is composed of multiple components that make the Application. 
2. Component is a Class that contains the programming logic developed using a language called Typescript along with UI developed on HTML, a CSS file for providing the styles for the component, along with a e2e UI testing file developed in TS. 
3. TypeScript is a JS based Programming language developed by MS for creating Type safe JS. It uses a compiler called Transpiler that will compile the TS file into a type safe ES standardized JS code.
4. Each component is a self contained unit of the Application that has features of the component without much dependencies from other components. The scope of the data is always within the limits of the Component.
5. To share the data among the Components, we have Services. 
6. We have PIPES to transform the data in the way we want to present in the User interface. 
7. We have interfaces to provide the data structure of the data that comes from the REST API. 
8. All Persistance data comes from external Web services developed using any Server side Scripting languages and technlogies like ASP.NET, SpringBoot, PHP and NODEJS. 
9. U can create Custom Directives to provide interpretations to std HTML elements and Custom HTML Elements. 
10. To load the components thru Hyperlinks and URL patterns, we hae Routing feature. 
11. The Main reasons for using Angular framework are : 
    - It supports powerful data Binding feature. 
    - It has DI feature that allows data to be injected from external sources into the components
    - It has powerful Async programming concepts that could be implemented in a faster and easier manner. 
    - It allows to intergrate external libraries and frameworks with little or less effort. 
    - As its developed by Google, the community is large and U get external support for developing the Apps at an industrial scale. 

## Commands to generate Components in Angular
1. ng g i Models/InterfaceName
2. ng g c Components/Calc
