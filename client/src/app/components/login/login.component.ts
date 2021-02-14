import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from 'src/app/shared/models/user.model';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup
  hide = true;
  user: User = new User();

  constructor(private userService:UserService, private router: Router) 
  {
    this.loginForm = new FormGroup(
      {
        id: new FormControl('', Validators.required),
        password: new FormControl('', Validators.required)
      }
    )
  }

  ngOnInit(): void {

  }

  login()
  {
    this.user.UserCode = this.loginForm.controls.id.value;
    this.user.Password = this.loginForm.controls.password.value;
    this.userService.login(this.user).subscribe(
      res => {localStorage.setItem('currenUser', res.toString());
      if(res.IsTeacher)
      this.router.navigate(['teacher-home'])
else this.router.navigate(['teacher-home'])
    },
      err => [console.log()]
    )
  }
}
