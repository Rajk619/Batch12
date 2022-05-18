class Calculate
{
    public Add(a:number,b:number):number
    {
        return a+b;
    }
    public Greet(name:string):string
    {
        return 'Hello '+name
    }
    public GetFlowers():string[]
    {
        return ["Rose","Lilly","Tulips"]
    }
    public IsEven(no:number):boolean
    {
        return no%2==0?true:false;
    }
}
let calc=new Calculate();
console.log(calc.Add(12,23))
console.log(calc.GetFlowers())
console.log(calc.Greet('Sachin'))
console.log(calc.IsEven(20)?'Even':'Odd')