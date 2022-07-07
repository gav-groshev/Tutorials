Ext.define('tutorial.view.Extra',{
   extend:'Ext.grid.Panel',
   xtype:'extra',
   title:'grid test',
   store:[
        { name: 'Jean Luc', email: "jeanluc.picard@enterprise.com", phone: "555-111-1111" },
        { name: 'Worf',     email: "worf.moghsson@enterprise.com",  phone: "555-222-2222" },
        { name: 'Deanna',   email: "deanna.troi@enterprise.com",    phone: "555-333-3333" },
        { name: 'Data',     email: "mr.data@enterprise.com",        phone: "555-444-4444" }
   ],
   columns:[
    {text:'Name', dataIndex:'name', flex:1},
    {text:'Email', dataIndex:'email', flex:1},
    {text:'Phone', dataIndex:'phone', flex:1},
   ],
   height:300,
   width:900
})