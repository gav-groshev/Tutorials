Ext.define('tutorial.view.Extra',{
   extend:'Ext.grid.Panel',
   xtype:'extra',
   title:'grid test',
   store:{
        type:'extraApi'
   },
//    bbar:{
//         xtype:'pagingtoolbar',
//         displayInfo:true
//    },
   columns:[
    {text:'Name', dataIndex:'name', flex:1, filter:'string'},
    {text:'Email', dataIndex:'email', flex:1},
    {text:'Phone', dataIndex:'phone', flex:1},
    {text:'Website', dataIndex:'website', flex:1},

   ],
   plugins:{
    gridfilters:true
   },
   height:700,
   width:1200,
   id:'testGrid',
   selModel:{
        injectCheckbox:'first',
        checkOnly:true,
        model:'SIMPLE',
        type:'checkboxmodel'
   }, 
   buttons:[
    // {
    //     text:'Select All',
    //     handler:function(){
    //         Ext.getCmp('testGrid').getSelectionModel().selectAll();
    //     }
    // },
    // {
    //     text:'Remove All',
    //     handler:function(){
    //         Ext.getCmp('testGrid').getSelectionModel().deselectAll();
    //     }
    // },
    // {
    //     text:'Get selected data',
    //     handler:function(){
    //         var data = Ext.getCmp('testGrid').getSelectionModel().getSelection();
    //         console.log(data);
    //     }
    // },
    {
        text:'Show Popup',
        handler:function(){
            pop= Ext.create('tutorial.view.PopUp');
            pop.show();
            console.log('abc');
        }
    }
   ]
})