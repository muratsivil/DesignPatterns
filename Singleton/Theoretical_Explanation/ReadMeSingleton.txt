
	Singleton Design Pattern: 

-->	It is one of the most popular structures belonging to Group X among design patterns. It has 80% usage rate according to international standards. The main goal is always to ensure that an object is created once and used repeatedly in different locations during the duration of the object's use. 

--> It proposes that an object instance is generated only once and always used. Checking the state of an object. In addition, especially the n-tier architecture, Singleton Design Patter is used if the sample of an object between layers only acts when passing between the relevant layers, that is, if it does not have a task such as keeping a value on it. For example, it is used when an object sample is needed that can also be stored at Layer Business or layer Associate and can be used in CRUD operations.

-->	When should we use it? When we produce an object with singleton, this object we produce always lives in the heap area of RAM until the ISP is restarted. So we have to be careful when creating an object using singleton. When creating an object with Singleton, we have to ask ourselves the question, "When i create an object with singleton, will everyone use this object very often?" If the answer is yes, produce it, if it is no, not produce it.

--> Another mechanism is that the control scope can also be created as a singleton object, and we must do this in the concrete class. This pattern is based on the principle that the class is started only once and that all requests are directed through this object. In the Singleton pattern, the class itself is responsible for ensuring the constraints, not the other classes that are affected by the class sampled.

--*!*-- For example, we have an object that is used to calculate payrolls at the end of the month, and only one person calls this object from the accounting unit, so we should not produce a sample of this object with singleton.

--> In cases where we want to create only a copy of a class with many patterns, such as Prototype, Builder, AbstracFactory, or where we want to provide this structure, the singleton pattern is used. The effectiveness of this model is based on developers using exactly the same rules. When used with other patterns, this pattern is also the most commonly used pattern in you.