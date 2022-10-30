import { Component, OnInit } from '@angular/core';
import { AuthUser } from '../_models/app-user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  authUser : AuthUser ={username:'toukky1',password:'123'};
  constructor(public accountService : AccountService) {

  }

  ngOnInit(): void {
  }

  login():void{
    console.log(this.authUser)
    this.accountService.login(this.authUser)
    .subscribe(res=>{
      console.log("res",res)
    });
  }

}
