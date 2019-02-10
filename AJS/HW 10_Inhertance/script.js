// console.log('is it working ')


// Homwwork ex 1 *************************************************

function Person ( { name, lastName, dateOfBirth, hometown } ) {
    this.name = name;
    this.lastName = lastName;
    this.dateOfBirth = dateOfBirth;
    this.hometown = hometown;
}

Person.prototype.sayFullName = function(){
    return `Hi my full name is ${this.name} ${this.lastName}`
}

let testObj ={
    name: "igor",
    lastName: 'Mitevski',
    dateOfBirth: "10.12.1988",
    hometown: "Delchevo"
}

let me = new Person(testObj);
console.log(me);
console.log(me.sayFullName());

Person.prototype.age =  function() {
    var dateString = this.dateOfBirth
    var today = new Date();
    var birthDate = new Date(dateString);
    var age = today.getFullYear() - birthDate.getFullYear();
    var m = today.getMonth() - birthDate.getMonth();
    if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
        age--;
    }
    return `You are ${age} years old`;
}

console.log(me.age())


// Homework task 2 88888***************************************************

function Trainer (obj) {
    let {course,teachingYears} = obj;
    this.course = course
    this.teachingYears=teachingYears
    Person.call(this,obj)
}



let testobj2 = {
    name: "Igor",
    lastName: 'Mitkovski',
    dateOfBirth: "05.04.1990",
    course: "Java Script",
    teachingYears: 6
}

Trainer.prototype=Object.create(Person.prototype);

Trainer.prototype.yearsOfteaching = function(){
    return `${this.name} is teaching the ${this.course} ${this.teachingYears} years`
}  // interesno ako go kacam nad linija 62 ne go prepoznava kako funcija >???


let myTrainer = new Trainer(testobj2);
console.log(myTrainer);  // zosto go pokazuva hometown dali moze da ne go pokazuva da ne dava undefined ???

console.log(myTrainer.sayFullName())
console.log(myTrainer.yearsOfteaching())
console.log(myTrainer.age())

/// HOome work bonus 1 *****************************************

let arr = [1, '3', { num: 7 }, 8, 'FunFunFunction', 10, () => `I'm a number`, 33] 

Array.prototype.getSumOfNumbers = function(){
    let result = 0;
    for (let i of this){
        if(typeof i==="number"){
            result+=i
        }
    }
    return result
}

console.log(arr.getSumOfNumbers()) // output 52


// Home work bonus part 2 **************************************


let keys = [], values = []
let person1 = {
    name: 'Martina',
    middleName: 'Luther',
    lastName: 'Queen'
}



const getNamesAndVals = obj => {
    let {name,lastName, middleName } = obj;
    values.push(Object.values(obj));
    keys.push(Object.keys(obj));
    return [keys, values];
}
console.log(getNamesAndVals(person1))
console.log(keys)
console.log(values)
