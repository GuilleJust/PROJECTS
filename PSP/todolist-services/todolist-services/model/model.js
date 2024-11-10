const mongoose = require('mongoose');

//Here we create the schema of the table
let tasksSchema = new mongoose.Schema({

    description:{
        type: String,
        minlength:1
    },

    type:{
        type:String,
        enum:['home', 'work', 'family', 'sport', 'undefined']
    },

    priority:{
        type:Number,
        min:1,
        max:5
    },

    done:{
        type:Boolean,
        status:false
    },

    difficulty:{
        type:Number,
        min:0,
        max:10
    }
});

let Task = mongoose.model('tasks', tasksSchema);
module.exports = Task;