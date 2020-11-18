import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { GameComponent } from './components/game/game.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterConfirmComponent } from './components/register-confirm/register-confirm.component';
import { RegisterStudentComponent } from './components/register-student/register-student.component';
import { RegisterComponent } from './components/register/register.component';
import { StatisticsComponent } from './components/statistics/statistics.component';
import { StudentMainComponent } from './components/student-main/student-main.component';
import { StudentsDetailsComponent } from './components/students-details/students-details.component';
import { StudentsComponent } from './components/students/students.component';
import { TeacherMainComponent } from './components/teacher-main/teacher-main.component';
import { WordComponent } from './components/word/word.component';


const routes: Routes = [
  {path:'home', component: HomeComponent},
  {path:'login', component: LoginComponent},
  {path:'teacherMain', component: TeacherMainComponent},
  {path:'studentMain', component: StudentMainComponent},
  {path:'register', component: RegisterComponent},
  {path:'registerConfirm', component: RegisterConfirmComponent},
  {path:'registerStudents', component: RegisterStudentComponent},
  {path:'studentsDetails', component: StudentsDetailsComponent},
  {path:'students', component: StudentsComponent},
  {path:'words', component: WordComponent},
  {path:'game', component: GameComponent},
  {path:'statistics', component: StatisticsComponent},
  {path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'students', loadChildren: () => import('./students/students.module').then(m => m.StudentsModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
