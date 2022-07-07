Ext.define('tutorial.view.main.ExtraController',{
    extend:'Ext.app.ViewController',
    alias:'controller.extra',
    init:function(){
        this.control({
            '#callController':{
                click:'callOnClick'
            },
            '#another':{
                click:'anotherClick'
            }
        })
    },
    callOnClick: function(){
        alert("Hello World from Controller");
    },
    anotherClick: function(){
        alert("another click")
    }

})