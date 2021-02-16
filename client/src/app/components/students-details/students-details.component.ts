import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/shared/models/user.model';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-students-details',
  templateUrl: './students-details.component.html',
  styleUrls: ['./students-details.component.css']
})
export class StudentsDetailsComponent implements OnInit {

  studentList: User[]=[];
  displayedColumns: string[] = ['id','firstName'];
teacherCode:number
currentTeacher:User;
  constructor(private userService: UserService) { }

  ngOnInit(): void {
 console.log(localStorage.getItem("currenUser"))
   this.currentTeacher=JSON.parse(localStorage.getItem("currenUser"))
   this.teacherCode=this.currentTeacher.UserCode;
   this.getStudentByTeacher(this.teacherCode,1)
  }

  getStudentByTeacher(tehcerCode, classCode)
  {
    this.userService.getStudentByTeacher(tehcerCode, classCode).subscribe((stdList:User[])=>this.studentList=stdList);
  }
}
