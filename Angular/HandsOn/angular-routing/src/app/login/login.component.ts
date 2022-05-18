import { Component, OnInit } from '@angular/core';
import { User } from '../user';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
users:User[];
uname:string;
pwd:string;
errMsg:string;
  constructor(private router:Router) {
    this.users=[
      {username:'Shiv',password:'12345',role:'admin'},
      {username:'Arjun',password:'12345',role:'customer'}
    ]
   }

  ngOnInit(): void {
  }
  Validate()
  {
    let user:User=this.users.find(u=>u.username==this.uname&&u.password==this.pwd)
    if(user!=null)
    {
      if(user.role=='admin')
      {
        //redirect to admin-dashboard
        this.router.navigateByUrl('admin-dashboard'); //navigate to admin-dashboard

      }
      else if(user.role=='customer')
      {
        //redirect to customer-dashboard
        this.router.navigateByUrl('customer-dashboard');
      }
    }
    else
    {
      this.errMsg='Invalid Credentials';
    }
  }

}
