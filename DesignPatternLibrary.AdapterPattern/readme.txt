The Adapter design pattern attempts to reconcile the differences between two otherwise-incompatible interfaces.
This pattern is especially useful when attempting to adapt to an interface which cannot be refactored (e.g. when the interface is controlled by a web service or API).

In our example the old legacy api is the "DivisionDatabank" (our ADAPTEE participiant), all those return methods should be properties in some object

The first thing we have to do is to create our object "Division" (our TARGET participiant)

The problem is that we cannot change our legacy api, here's where our (ADAPTER participiant) comes into play.

Our ADAPTER participiant 'SuperDivision' has to inherit from 'Division' but maintains a reference to the API such taht the API's data can be loaded into an intance 
of the 'Division' class

- Source: https://exceptionnotfound.net/the-daily-design-pattern-adapter/