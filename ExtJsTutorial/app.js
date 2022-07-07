/*
 * This file launches the application by asking Ext JS to create
 * and launch() the Application class.
 */
Ext.application({
    extend: 'tutorial.Application',

    name: 'tutorial',

    requires: [
        // This will automatically load all classes in the tutorial namespace
        // so that application classes do not need to require each other.
        'tutorial.*'
    ],

    // The name of the initial view to create.
    mainView: 'tutorial.view.main.Main'
});
