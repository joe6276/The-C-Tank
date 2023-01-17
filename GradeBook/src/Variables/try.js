 let datafromdb=[
{
    questionid:1,
    answerId:"sxdsfd",
},
{
    questionid:4,
    answerId:"sas",
},
{
    questionid:3,
    answerId:"fdsg",
},
{
    questionid:3,
    answerId:"fdsg",
}

]

let result =[]


datafromdb.map((x)=>{
    let found= result.find(y => x.questionid==y.questionid)

    if(found){
        found.answers=[...found.answers , x.answerId]
    }
    let p = {questionid: x.questionid , answers:[x.answerId]}
     result.push(p)
})

console.log(result);
