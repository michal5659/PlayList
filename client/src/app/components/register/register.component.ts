import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { User } from 'src/app/shared/models/user.model';
import { UserService } from 'src/app/shared/services/user.service';
import {map, startWith} from 'rxjs/operators';
import { Router } from '@angular/router';
import { School } from 'src/app/shared/models/school.model';
import { SchoolService } from 'src/app/shared/services/school.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  teacher:User=new User();
  schoolList:School[]=[];

  myControl = new FormControl();
  
  filteredOptions: Observable<School[]>;
  allSchools:School[]=[];
  hide = true;

  constructor(private userService:UserService,private schoolService: SchoolService, private router: Router) { 
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

    this.getListOfSchool();
  //     this.myControl.valueChanges.pipe(
  //     map(value => this._filter(value))
  //   ).subscribe(res=>this.schoolList=res);   
   }

   _filter(value: string) {
    

    this.schoolList= this.allSchools.filter(option => option.SchoolName.indexOf(value) === 0);
  }

  register()
  {
    if(this.registerForm.valid)
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
        res=>alert(res)
      )
      this.router.navigate(['/teacherMain']);
    }
    else
    {
      alert('יש למלא את כל הפרטים')
    }

  }

  getListOfSchool()
  {
   this.filteredOptions=  this.schoolService.schoolList()
   this.schoolService.schoolList().subscribe(res=>{this.allSchools=res; this._filter("")})
  }
}
