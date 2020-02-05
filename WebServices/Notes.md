# Curriculum
- Week 04 Web Services
    - Service Oriented Architecture
    (Patterns, Principles, Endpoint, Address, Binding, Contract)
    - SOAP
    (Envelope, Header, Body)
    - WCF
    - WSDL
    (Port, Binding, PortType, Operation)
    - REST Fundamentals
    (Uniform-Interface, Client-Server, Stateless, Cacheable, Layered, Code-On-Demand)
    - HTTP
    (Method, Safe, Idempotent, Status-Code, Header-Request, Header-Response)
    - REST Server
    (CORS, XSS, CSRF)
    - Media Type
    (JSON, Content-Negotiation, Action-Result Types, Formatter)
    - REST Client
    (Consumer, Http-Client)
    - Security
    (Authentication, Authorization)
    - JavaScript
    (ES5, ES6, Truthy-Falsy, Equality-Loose, Datatypes, DOM, JSON, Prototypes, Scopes)
    - Functions
    (Arrow, Callback, Closure, IIFE)
    - Ajax Fundamentals
    (Fetch API, HTTP Verbs, XmlHttpRequest)
    - Event Handlers
    (Listeners, Propagation)

## SOA:
- *Complex Engineered System*
    - Traditional (1970 to late 1990s): Homogeneous, bounded and static
    - where as business demands : hetrogeneous, unbounded, dynamic, undefined and composed of autonomous elements instead.  
    - Mordern Complex Engineered System needs to be designed in such a way that:
        - focused on services over properties of components
        - interoperability & cross platform functionality
        - flexible,loosely coupled and distributed to enforce diversity on high level components autonomy of the components.
        - abstraction to avoid overwhelming complexity
        - this acheived via SOA in early (2000s)
    - SOA : Service Oriented :  is an approach to distributed systems architecture that employ loosely couple services standard interfaces and protocols to deliver seamless cross-platform integration.
    - Integration via protocols and standard interfaces
    - Eg: Parking paying tickets online Systems - traditional approach
        - spend years on developing street maps
        - subset for payment
        - login and user auth
        - logic functionality for parking tickets systems
                or
        - integrate google maps for location
        - paypal integration for payment
        - user login with fb
    - when we create a service it is self contained autonomous unit (have fully control over it)
    - Service should have a standard interface that tells (who i am, what i do, input, output), yellow sign above the bin that broadcasting to encourage customer to dispose waste (this is called as service discovery)
    - services define contract as mode of communication (language for staff), here it should be protocol.


    Eg: Coffee shop as SOA - Service (Employee, Furniture as a service, bill) as a system designer we need not to do what this needs to do, only the service provider witll know the logic behind it. So services should be automated and abstracted as well.
    - AUTONOMOUS: when we create a service it is self contained autonomous unit (have fully control over it)
    - INTERFACE: Service should have a standard interface that tells (who i am, what i do, input, output) like coffee pack has a label, yellow sign above the bin that broadcasting to encourage customer to dispose waste (this is called as service discovery- communicative metadata which can be used to effectively effectively discover and interpreted)
    - SERVICE CONTRACT: services define contract as mode of communication (language for staff), here it should be protocol. Services are created with one or more service descriptions.
    - DYNAMIC PROVISIONING : Network of the service is flexible to incorporate more services, like cleaning, new staff agency- by calling recruitment etc. So service flexible enough to provision or de-provision the other services.
    - SERVICE RESUABLITY: I can expand by opening a restaurant, bar etc and then I can re-use existing services to serve my purpose.They can endlessly used, re-used, composed and recomposed


## AAD B2C:

- tenant - your org that consists of dir of users

## Demo
- create a tenant on Azure B2C
- Link the tenant to Azure Subscription.
- Register your App.
