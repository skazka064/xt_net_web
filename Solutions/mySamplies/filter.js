let users = [
    {id:1, name: "Вася"},
    {id:2, name: "Петя"},
    {id:3, name: "Маша"}
];
let someUsers = users.filter(item=>item.id<3);
console.log(someUsers);