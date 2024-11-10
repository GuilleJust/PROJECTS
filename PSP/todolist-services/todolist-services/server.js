const mongoose = require('mongoose');
const express = require('express');
const bodyparser = require('body-parser');
const Task = require('./model/model');

//We make the conection
mongoose.Promise = global.Promise;
mongoose.connect('mongodb://127.0.0.1:27017/tasks',
    {useNewUrlParser: true, useUnifiedTopology: true});

    let app = express();
    
    app.use(bodyparser.json());

    //Function to get all tasks
    app.get('/tasks', (req, res) =>{
        Task.find().then(result =>{
        res.send(result)
        })
    });

    //Function to post a task
    app.post('/tasks', (req, res) =>{
        let newTask = new Task({
            description: req.body.description,
            type: req.body.type,
            priority: req.body.priority,
            done: req.body.done,
            difficulty: req.body.difficulty
        });

        newTask.save().then(result =>{
            let data = {error: false,  result: result};
            res.send(data);
        }).catch(error =>{
            let data = {error: true, errorMessage:"Error addding task"};
            res.send(data);
        });
    });

    //Function to get tasks by type
    app.get('/tasks/type/:type', (req,res) =>{
        Task.find({type:req.params.type}).then(result =>{
            if(result){
                let data = {error: false, result:result};
                res.send(data);
            }else{
                let data = {error: true, errorMessage: "Type not found"};
                res.send(data);
            }
        }).catch(error =>{
            let data = {error: true, errorMessage:"Error getting type"};
            res.send(data);
        });
    });

    //Function to get tasks by priority
    app.get('/tasks/priority/:priority', (req,res) =>{
        Task.find({priority:req.params.priority}).then(result =>{
            if(result){
                let data = {error: false, result:result};
                res.send(data);
            }else{
                let data = {error: true, errorMessage: "Priority not found"};
                res.send(data);
            }
        }).catch(error =>{
            let data = {error: true, errorMessage:"Error getting priority"};
            res.send(data);
        });
    });

    //Function to get tasks by done or not
    app.get('/tasks/done/:done', (req,res) =>{
        Task.find({done:req.params.done}).then(result =>{
            if(result){
                let data = {error: false, result:result};
                res.send(data);
            }else{
                let data = {error: true, errorMessage: "Done or not done tasks not found"};
                res.send(data);
            }
        }).catch(error =>{
            let data = {error: true, errorMessage:"Error getting done or not tasks"};
            res.send(data);
        });
    });

    //Function to get tasks by difficulty
    app.get('/tasks/difficulty/:difficulty', (req,res) =>{
        Task.find({difficulty:req.params.difficulty}).then(result =>{
            if(result){
                let data = {error: false, result:result};
                res.send(data);
            }else{
                let data = {error: true, errorMessage: "Indicated difficulty tasks not found"};
                res.send(data);
            }
        }).catch(error =>{
            let data = {error: true, errorMessage:"Error getting indicated difficulty tasks"};
            res.send(data);
        });
    });

    //Function to update tasks by ID
    app.put('/tasks/:id', (req, res) => {
        Task.findByIdAndUpdate(req.params.id, {
            $set: {
                description: req.body.description,
                type: req.body.type,
                priority: req.body.priority,
                done: req.body.done,
                difficulty: req.body.difficulty
            }
        }, {new: true}).then(result => {
            let data = {error: false, result: result};
            res.send(data);
        }).catch(error => {
            let data = {error: true,
            errorMessage:"Error updating task"};
            res.send(data);
        });
    });
       
    //Function to delete tasks by ID
    app.delete('/tasks/:id', (req, res) => {
        Task.findByIdAndRemove(req.params.id).then(result => {
            let data = {error: false, result: result};
            res.send(data);
        }).catch(error => {
            let data = {error: true,
            errorMessage:"Error removing task"};
            res.send(data);
        });
    });
       

    app.listen(8080);