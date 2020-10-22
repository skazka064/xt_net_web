class Service {
    constructor() {
        this.map = new Map();
    }

    add(obj) {
        if (obj == null || obj == undefined)
            return null;

        let id = Math.random().toString().substr(2,10);
        this.map.set(id, obj);
        return id;
    }
    getById(key){
        map.has(key)? map.get(key):null;
    }
    getAll(){
        return this.map.values();
    }
    deleteById(key){
        this.map.delete(key);
    }
    updateById(id,obj){
        this.map.set(id,obj);
    }
    replaceById(id, obj) {
        if (id == null || id == undefined || obj == null || obj == undefined)
            return;

        if (this.map.has(id))
            this.map.delete(id);

        this.map.set(id, obj);
    }

}

let storage = new Service();
let obj1 = storage.add({name:"Ivan"});
let all= storage.getAll();
console.log(all);
