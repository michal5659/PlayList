import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/internal/operators/map';
import { startWith } from 'rxjs/internal/operators/startWith';
import { School } from 'src/app/shared/models/school.model';
import { User } from 'src/app/shared/models/user.model';
import { SchoolService } from 'src/app/shared/services/school.service';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-register-student',
  templateUrl: './register-student.component.html',
  styleUrls: ['./register-student.component.css']
})
export class RegisterStudentComponent implements OnInit {

  studentRegisterForm: FormGroup;
  student:User=new User();

  myControl = new FormControl();
  schoolList:School[]=[];
  filteredOptions: Observable<School[]>; 
  allSchools:School[]=[];

  constructor(private userService:UserService, private schoolService: SchoolService , private router: Router) 
  {
    this.studentRegisterForm = new FormGroup({      
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
  }

  _filter(value: string){
    this.schoolList= this.allSchools.filter(option => option.SchoolName.indexOf(value) === 0);
  }

  register()
  {
    this.student.UserCode=this.studentRegisterForm.controls.id.value;
    this.student.FirstName=this.studentRegisterForm.controls.firstName.value;
    this.student.LastName=this.studentRegisterForm.controls.lastName.value;
    this.student.ID=this.studentRegisterForm.controls.id.value;
    this.student.Password=this.studentRegisterForm.controls.password.value;
    this.student.Email=this.studentRegisterForm.controls.email.value;
    this.student.LayerNumber=this.studentRegisterForm.controls.layerNumber.value;
    this.student.SchoolCode=this.studentRegisterForm.controls.schoolCode.value;
    this.userService.registerTeacher(this.student).subscribe(
      res=>alert(res)
    )
    this.router.navigate(['/studentMain']);
  }

  uploadFile(fileInput)
  {
    this.userService.uploadStudentsDetailes(fileInput.files[0]).subscribe();
  }

  getListOfSchool()
  {
   this.filteredOptions=  this.schoolService.schoolList()
   this.schoolService.schoolList().subscribe(res=>{this.allSchools=res; this._filter("")})
  }
}
