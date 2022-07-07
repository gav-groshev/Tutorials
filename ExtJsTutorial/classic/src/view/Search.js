Ext.define('tutorial.view.Search',{
    extend:'Ext.form.Panel',
    xtype:'search',
    title:'Search',
    defaultType:'textfield',
    items:[
        {
            fieldLabel:'First Name',
            name:'firstName'
        },
        {
            fieldLabel:'Last Name',
            name:'lastName'
        },
        {
            fieldLabel:'Email',
            name:'email'
        },
        {
            xtype:'datefield',
            fieldLabel:'DOB',
            name:'dob'
        },
    ],
    buttons:[
        {
            text: 'Submit me',
            handler:function(btn){
                var data = this.up('form');
                console.log(data.getForm().getValues());
            }
        },
    ]
})