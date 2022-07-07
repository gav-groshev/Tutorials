Ext.define('tutorial.view.PopUp',{
    extend:'Ext.window.Window',
    height:200,
    width:400,
    layout:'fit',
    items:{
        xtype:'grid',
        border:false,
        columns:[
            {header: 'Name', dataIndex:'name'},
            {header: 'Email', dataIndex:'email'},
        ],
        store:{
            type:'extraApi'
       },
    }
})