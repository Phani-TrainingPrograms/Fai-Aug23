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

## Interaction b/w the components: 
1. From the parent component to the child component, we use Input Directive which works like attributes that can be set from the parent component. 
2. From the child to the parent component, we use Output Directive which is an instance of EventEmitter, the event creator in Angular Apps. The EventEmitter's emit function is used to trigger the event, it can have any data type that could be emitted from the child to the parent(Caller) component. 

## Pipes in Angular
- Pipes are transformation code that makes UI render the content as per the transformation of the HTML Content. 
- There are built in pipes that help in transforming the data as: 
    - uppercase
    - lowercase
    - currency
    - json
    - Percentage
    - Decimal
    - Date
- U can create Custom pipes using the CLI:
    - ng g p Pipes/PipeName --skip-tests
- Custom Pipes are classes in Angular that has Pipe Directive and implements an interface called PipeTransform.
- The PipeTransform interface has one method called transform that contains the logic of modifing the data into the format U want to present. 

## Services in Angular
- A service is an injectable class which maintains a single reference across the components of the module. 
- The scope of the service is limited to the module that U use it. 
- A service is required to share the data and functions that can be used across the components of the module. 
- It maintains a single reference where ever U use it within the module. 
- The references of this service can be injected into the components using the DI feature of Angular. 
- Services are created using the CLI Command: 
```
ng generate service Services/ServiceName    
```

## Forms in Angular
- Forms are required to perform client side validations on inputs provided by the Angular Apps.
- There are 2 ways of performing validations in Angular
    - Reactive Forms
    - Template Driven Forms
- Template Driven Forms use the HTML Elements and its attributes to perform the client side validations like Email, required, Min and Max and many more. 
- Reactive Forms are more object oriented and use the Angular features to perform the validations required for the models. It is also called as Model driven Validations. 

## Modules in Angular
- Modules are independent Blocks of the Applications that contain one or more components with services, pipes and directives to become a part of the Application. 
- Modules was introduced from Angular 5.
- Modules allow to be created and loaded at runtime, instead of loading it at the start of the Application. This feature of loading the Units as and when it is required is called as Lazy Loading. The Opposite of Lazy loading is Eager Loading. 
- U cannot do Lazy loading with Components, U have bind those components into a module and load the Module at runtime. 
- Modules are created using the following command:
```
ng generate module Modules/ModuleName
```
