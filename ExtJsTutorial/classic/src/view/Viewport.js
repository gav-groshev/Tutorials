Ext.define('tutorial.view.Viewport',{
    extend:'Ext.container.Viewport',
    id:'viewport',
    items:[
        {
            region:'north',
            html:'<h1>Header part</h1>'
        },
        {
            region:'center',
            xtype:'tabpanel',
            activeTab:0,
            itemId:'viewport-target',
        },
        {
            region:'footer',
            html:'<h1>Footer part</h1>'
        }
    ]
})