import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { Class } from 'src/app/shared/models/class.model';
import { DiagramData } from 'src/app/shared/models/diagramData.model';
import { User } from 'src/app/shared/models/user.model';
import { Week } from 'src/app/shared/models/week.model';
import { WordCategory } from 'src/app/shared/models/wordCategory.model';
import { StatisticsOnStudentService } from 'src/app/shared/services/statistics-on-student.service';
import { TeacherService } from 'src/app/shared/services/teacher.service';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.css']
})
export class StatisticsComponent implements OnInit {

  selectedTeacher:User=new User();
  selectedClass:Class=new Class();
  selectedStudent:User=new User();
  selectedCategory:WordCategory=new WordCategory();
  selectedWeek
  classList:Class[]=[];
  studentList:User[] = [];
  WeekList:Week[] = [];
  CategoryList:WordCategory[]=[]
  weekDiagram: DiagramData=new DiagramData();
  categoryDiagram: DiagramData = new DiagramData();
  classLoded:boolean=false;
  constructor(private statisticsService: StatisticsOnStudentService, 
    private teacherService: TeacherService
    ) { }

  
  ngOnInit(): void {
    
    this.selectedTeacher =JSON.parse(localStorage.getItem('currenUser'));
   //this.selectedTeacher.UserCode=1;
    this.getClassListForTeacher();
  }

  getClassListForTeacher() {
      this.teacherService.getClassListForTeacher(this.selectedTeacher.UserCode).
      subscribe(res=>
        this.classList=res)
  }

  getStudentListForTeacher() {
    this.teacherService.getStudentListForTeacher(this.selectedTeacher.UserCode, this.selectedClass.ClassCode).
      subscribe(res =>
        this.studentList = res)
  }
  getWeekListForClass() {
    this.teacherService.getWeekListForClass(this.selectedClass.ClassCode).
      subscribe(res =>
        this.WeekList = res)
  }

  getCategoryListForClass() {
    this.teacherService.getCategoryListForClass(this.selectedClass.ClassCode).
      subscribe(res =>
        this.CategoryList = res)
  }


  updateDataWhenClassChanged(){
    //this.getClassListForTeacher();
    //this.getCategoryListForClass();
    //this.getWeekListForClass();
    this.getStudentListForTeacher();
    this.getClassStatistics();
      
  }


  updateDataWhenStudentChanged() {
  this.getStudentStatistics();
  }
  getClassStatistics()
  { debugger

    this.statisticsService.classStatistics(this.selectedClass.ClassCode).subscribe(res=>
      {
        this.categoryDiagram=res[0]
        this.weekDiagram=res[1]
        console.log(res)
        console.log(this.categoryDiagram)

        this.classLoded=true;
      }
      );
  }

  getStudentStatistics() {
    this.statisticsService.studentStatistics(this.selectedStudent.UserCode).subscribe(res => {
      this.categoryDiagram = res[0]
      this.weekDiagram = res[1]
    }
    );
  }



  lineChartOptions = {
    responsive: true,
  };

  lineChartColors: Color[] = [
    {
      borderColor: 'black',
      backgroundColor: 'rgba(255,255,0,0.28)',
    },
  ];

  lineChartLegend = true;
  lineChartPlugins = [];
  lineChartType = 'line';



  barChartOptions: ChartOptions = {
    responsive: true,
  };
  barChartType: ChartType = 'bar';
  barChartLegend = true;
  barChartPlugins = [];







}
