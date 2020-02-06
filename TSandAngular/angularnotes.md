- install angular cli `npm install -g @angular/cli`
## Terms:
- root module - AppModule class in app.module.ts
- modules - collection of components, directives in a functional group
- Components - an object that controls view. 
- Directives - anything that changes the behaviors
- Decorators - make TS classes into Angular things. Eg:  @NgModule, @Component, @injectable

In TS:
- ng modules are classes.
- ng services are classes.
- ng components are classes. 
- decorators(TS thing) make TS classes into Angular things


CLI Commands:
- `ng new appName` - creates a new project for you with predetermined config files.
- `*ngFor` - `NgForOf directive`structural directive:_Structural directives shape or reshape the DOM's structure, typically by adding, removing, and manipulating the elements to which they are attached. Any directive with an `*` is a structural directive_
- `*ngIf` directive : I think it checks for truthy or falsy values.
- Data Binding :
    - Interpolation -> `{{}}` data: string -> view -> angular
    _`Interpolation {{ }}`: lets you render the property value as text_
    - `property binding ->[]`: 
    _property binding [ ] lets you use the property value in a template expression._ 
    - `Event binding` - (eventname)="eventhandler()";
    - `Two-way binding` - [()] - aka banana in a box. This needs [(ngModel)]

- [Components](https://angular.io/guide/architecture-components) - define areas of responsibility in your UI that let you reuse these sets of UI functionality. Component specify 3 things:
    - Component class : .ts file 
        ` @Component decorator indicates that the following class is a component. It provides metadata about the component, including its templates, styles, and a selector`
    - HTML Template: .html file
    `The selector is used to identify the component. The selector is the name you give the Angular component when it is rendered as an HTML element on the page. By convention, Angular component selectors begin with the prefix app-, followed by the component name.`
    - Component-specific styles : .css file
_An Angular application is composed of a tree of components, in which each Angular component has a specific purpose and responsibility._
- Generally `app-root` is the application shell. This is the first component to load, and the parent of all other components. You can think of it as the base page.
- [Decorators]:
    - `@Component`: metadata about the component, including its templates, styles, and a selector
    - `@Input` : decorator indicates that the property value will be passed in from the component's parent. It's an instance of Input Object of angular/core module
    -  `@Output` : decorator and an instance of event emitter. This makes it possible for the component to emit an event when the value of the notify property changes.

## Routing
-`Angular router`:  enables you to show different components and data to the user based on where the user is in the application. The router enables navigation from one view to the next as users perform application tasks:
    - Enter a URL in the address bar, and the browser navigates to a corresponding page.
    - Click links on the page, and the browser navigates to a new page.
    - Click the browser's back and forward buttons, and the browser navigates backward and forward through the history of pages you've seen.
- A route associates one or more URL paths with a component.
 - The `routerLink` directive defines how the user navigates to the route (or URL) declaratively in the component template. The RouterLink directive gives the router control over the anchor element.
 - The `ActivatedRoute` is specific to each routed component loaded by the Angular Router. It contains information about the route, its parameters, and additional data associated with the route.

 ## Contact Demo:
 ```
 src
    app -> Calls App Modules
        contact-details
            contact-details.component.ts|.html|.css
            contact-detail
                contact-detail.component.ts|.html|.css
            contact-detail-list
                contact-detail-list.component.ts|.html|.css
            shared
                contact-detail.service.ts
                contact-detail.model.ts
    app.module.ts
index.html (cdn path for boostrap)
 ```
 - ng new contactweb
 - ng serve --o -> see localhost:4200 sensing the app
 - add [bootstrap](https://getbootstrap.com/docs/4.3/getting-started/introduction/)
 - add [fontawesome]()
 - in app folder delete app.component.css and app.component.spec.ts
 - app.component.ts use styles: [] instead of styleUrls: ['./app.component.css']
 - generate first component: `ng g c contact-details --skipTests=false --inline-style` or ` ng g c contact-details --spec=false --s`- create service without test
 - `ng g c contact-details\contact-detail --skipTests=false --inline-style` - create service without test
 - `ng g c contact-details\contact-detail-list --skipTests=false --inline-style` - create service without test
 - `ng g s shared\contact-detail --spec=false` : create service without test
 - `ng g cl shared\contact-detail --type=model --spec=false` : create model without test