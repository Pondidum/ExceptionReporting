Types:
======

There are three ways of doing this:

* Simple
	* It�s just a list of handlers, and are processed in order, until one of them returns `False` from its `.Continue` property, or until no more handlers are available.
	* The down side to this is that there is an in memory copy of each handler for the lifetime of the application.  This is probably only one or two classes, but still.

* Lazy Handler Creation
	* This runs on a similar system of handlers, all being processed in order, until a handler returns `False` from its `.Continue` property.
	* This will use less memory for normal operation, as handlers are not created until exceptions are reported.
	* However, if many exceptions are thrown, there will be more handlers created, although Garbage Collection should deal with it.

* Cascaded Handlers
	* Each handler has a property for `NextHandler`, and each handler is processed until a handler returns `False` from its `.Continue` property, or no handler is returned from `NextHandler`
	* This allows a greater amount of flexibility - one handler could have two other handlers specified, and pick one based on user input.
	* This could be implemented as LazyLoad too.

Acknowledgements:
================

* Icons are from the [Crystal Icon Pack][1]
* All design is by me, and provided as is.


[1]: http://www.everaldo.com/crystal/
