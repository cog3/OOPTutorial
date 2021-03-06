# What is Object Oriented Programming? 

Object Oriented Programming is a programming concept, used to develop applications. 
It is a fairly simple concept, once you understand its **Four Principles**.

* Encapsulation
* Abstraction
* Inheritance
* Polymorphism

## Why is this important? 

Whenever you write code, you never want to do unneccesary work. Like when you write an essay, you want to avoid repeating yourself as much as possible. These Object Oriented coding principles saves you a lot of time, makes your program easier to read, and makes your program more efficient! 

#### *Lets explain why each principle is so important* 

### Encapsulation

When you make a class, it is very important to know what properties, fields, variables, or methods you will make public or private. Many times, you do not want other classes, or objects of a particular class, to change anything about the class you are working on. This is called *Encapsulation*. Think of Encapsulation as the sole protector of your precious classes.

Let's say we are making a game where you own a cat, named *Whiskers*. You play, sleep, and feed Whiskers whenever you please. But, Whiskers is also his own person. He chooses when to meow.\
In this case, we cannot let you, the player, have control over Whiskers' sleep, eat, and meow functionalities. But you do control if you feed, bathe, or play with Whiskers.\
*Lets see how it looks*\
![Cat](https://github.com/cog3/OOPTutorial/blob/master/Encapsulation/Cat.PNG) ![Human](https://github.com/cog3/OOPTutorial/blob/master/Encapsulation/Human.PNG)


### Abstraction

Imagine you going to develop a video streaming website that is going to beat YouTube! You are going to need to build a website that holds millions of videos and billions of views. This all sounds impossible, luckily, one Object Oriented Programming principle that makes this more achievalble is *Abstraction*. Abstractions comes hand in hand with Encapsulation Applying abstraction means that an object should only make things available that other objects/functions are going to use. Like our Cat example, the Meow() method was *abstracted* out so that no other object can use it. This allows a programmer to use different functions for specific things so it can be reused many times! \
As an example, we are going to reference a cell phone. Cell phone's are a perfect example of abstraction, because each button has one specific functions for the user, eventhough under-the-hood there is so much going on. \
![Phone](https://github.com/cog3/OOPTutorial/blob/master/Abstraction/Phone.PNG)


### Inheritance

Since Encapsulation and Abstraction help us right a baggilion lines of code without having to repeat ourselves, now, what happens if we have so many objects that are similar, but are quite not the same. Imagine if you have a very big family. Starting with your grandparents, they may have 10 children because that was normal back in the day. If we are going to right a program to create the family, it will be so annoying to write the same code over and over again for the 10 children. This is where Inheritance comes into play. All children have a lot of similar attributes, but each one may be unique in their own way. Lets see an example .. \
\
Here, in the Family Class we initialized all of the Family's basic information. Now, if we were to add Children, all we have to do is assign each child a name while importing a new Object of class Family so that the child can have all the data necessary. Imagine having to code all of the family information all over again for every child?!

![Family](https://github.com/cog3/OOPTutorial/blob/master/Inheritance/Family.PNG) ![Child](https://github.com/cog3/OOPTutorial/blob/master/Inheritance/Child.PNG)


### Polymorphism
>In Greek, Polymorphism means, *many shapes*.

Just how Encapsulation and Abstraction go hand-in-hand, so does Inheritance and Polymorphism. With Inheritance, we see how you can have a parent or super-class to create other classes. This saves a lot of time while you code, because it reduces the amount of the classes you need to make for endless objects. Now, with Polymorphism, we see how we can use Objects from different Classes together to preform similar goals. The exact Computer Science definition of Polymorphism is, *polymorphism is the provision of a single interface to entities of different types or the use of a single symbol to represent multiple different types*. Let's simplify this with, ANIMALS!

![Turtle](https://github.com/cog3/OOPTutorial/blob/master/Polymorphism/Turtle.PNG) ![Dog](https://github.com/cog3/OOPTutorial/blob/master/Polymorphism/Dog.PNG) ![Cat](https://github.com/cog3/OOPTutorial/blob/master/Polymorphism/Cat.PNG) 
![Animal](https://github.com/cog3/OOPTutorial/blob/master/Polymorphism/Animal.PNG)

We can use Animal as a wrapper class (supper-class) to extand over to the child classes (Turtle, Dog, and Cat). With this, anything in the Animal Object must be present in the child classes, although we did not implement that. The super class can make Objects from its child classes but the child classes cannot do the same. This way, we can make an array of Animals, no matter what *Type* the animal is. 

