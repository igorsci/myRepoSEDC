console.log("is it workingn");

// building a model for starshipos of star wars how. The tast is to present three ships from the starwars 
// we should use classes 
// Model properties
// Starships
// name
// pilot
// fuel tank capacity
// current location
// type of starship
// (method) start engines
// (method) take off
// (method) land


// Fighter
// weapons
// shield
// number of kills
// (method) shoot weapon #1
// (method) shoot weapon #2
// (method) shoot weapon #n



// Cargo Shipt
// cargo capacity
// trading route/manifest
// loading cranes
// (method) load
// (method) unload



// Mining Ship
// mining tools
// mining types
// mining storage capacity
// (method) mine/harvest
// (methid) set storage temperature


// na kraj da gi prikazeme istite na ekrano 

class Starship {
    constructor(name,pilot,fuel,location,type){
        this.name = name
        this.pilot=pilot
        this.fuel_tank_capacity=fuel
        this.current_location=location
        this.type=type
    }
    startEngine(){
        return console.log(`Engine started`)
    }

    takeOff(){
        return console.log(`The ship take off`)
    }

    isLanded(){
        return console.log(`The ship landed`)
    }
}


// fighter ship constructor // amazing if we made one method for shuting i

class Fighter extends Starship {
    constructor(name, pilot, fuel, location, type, weapons, shield, kills){
        super(name, pilot, fuel, location, type);
        this.weapons = weapons;
        this.shield = shield;
        this.kills = kills;
    }

    shootWeapon(weapon){
        if(weapon){
            return `Weapon ${weapon} fired!`;
        }else if(this.weapons[0]){
            return `Weapon ${this.weapons[0]} fired!`;
        }else{
            return `Starship has no weapons`;
        }
 
    }

}


// cargo ship constructor 

class Cargo extends Starship {
    constructor(name, pilot, fuel, location, type, capacity, route, cranes){
        super(name, pilot, fuel, location, type);
        this.capacity = capacity;
        this.route = route;
        this.cranes = cranes;
    }

    load(){
        return `Cargo loaded!`;
    }

    unload(){
        return `Cargo unloaded!`;
    }

}


// mining ship constructor 

class Mining extends Starship {
    constructor(name, pilot, fuel, location, type, mining_tools, mining_types, mining_capacity){
        super(name, pilot, fuel, location, type);
        this.mining_tools = mining_tools;
        this.mining_types = mining_types;
        this.mining_capacity = mining_capacity;
    }

    mine(){
        return `Mining`;
    }

    setStorageTemperature(temperatue){
        return `Temperature set on ${temperatue} degrees`;
    }

}


let dataStarships = [];
dataStarships.push(
new Fighter("F1","John", 50,"Earth","Fighter",["Rockets","Laser"], 15,2))
dataStarships.push(new Fighter("F2","Luke", 50,"Mars","Fighter",["Bulets","gun"], 30,4))
dataStarships.push(new Mining('M1','Stojan',200,"Venera",'Mining',['lopata','kopac'],'Premium',60))
dataStarships.push(new Mining('M2','Igor',250,"Jupiter",'Mining','DveLopati','Premium',65))
dataStarships.push(new Cargo('C1',"Pilot",66,'Venera','Cargo',98,'Skopje-Del',6))
dataStarships.push(new Cargo('C2',"Pilot1",88,'Earth','Cargo',98,'Earth-Mars',98))
console.log(dataStarships);

let appendTable = arr => {
    let header = Object.keys(...arr);
    // console.log(header)
    // console.log(obj);
    // let hederValues = Object.values(obj);
    // console.log(hederValues);
    $("#body").append(`<tr>`);
    for (let i=0; i<header.length; i++) {
        $('#body').append(`
                <td>${header[i]}</td>
                `)
    }
    $('#body').append(`</tr>`);
    for (const obj of arr) {
        let str = '<tr>'
        for(const key in obj) {
            str+=`<td>${obj[key]}</td>`
        }
        str += '</tr>'
        $('#body').append(str)
    }
}

$(() => {
    $('#goHome').on('click', appendTable(dataStarships))
    $('#getPeople').on('click', () => {
        showPeople()
        getData(db.people)
    })
    $('#getPlanets').on('click', () => {
        showPlanets()
        getData(db.planets)
    })
})


// appendTable(dataStarships)
