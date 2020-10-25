import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { User } from 'src/app/shared/models/user.model';
import { UserService } from 'src/app/shared/services/user.service';
import {map, startWith} from 'rxjs/operators';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  teacher:User=new User();

  myControl = new FormControl();
  options: string[] = ['1', '2', '3'];
  filteredOptions: Observable<string[]>;

  hide = true;

  constructor(private userService:UserService) { 
    this.registerForm = new FormGroup({      
      firstName: new FormControl('', Validators.required),
      lastName: new FormControl('', Validators.required),
      id: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),
      confirmPassword: new FormControl('', Validators.required),      
      email: new FormControl('', Validators.required),
      schoolCode: new FormControl('', Validators.required),
      layerNumber: new FormControl('')
    })
  }

  ngOnInit(): void {

    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map(value => this._filter(value))
    );   
  }

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();

    return this.options.filter(option => option.toLowerCase().indexOf(filterValue) === 0);
  }

  register()
  {
    this.teacher.UserCode=this.registerForm.controls.id.value;
    this.teacher.FirstName=this.registerForm.controls.firstName.value;
    this.teacher.LastName=this.registerForm.controls.lastName.value;
    this.teacher.ID=this.registerForm.controls.id.value;
    this.teacher.Password=this.registerForm.controls.password.value;
    this.teacher.Email=this.registerForm.controls.email.value;
    this.teacher.LayerNumber=this.registerForm.controls.layerNumber.value;
    this.teacher.SchoolCode=this.registerForm.controls.schoolCode.value;
    this.userService.registerTeacher(this.teacher).subscribe(
res=>
alert(res)
    )
  }

}
