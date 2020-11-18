import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GameComponent } from '../components/game/game.component';

import { StudentsComponent } from './students.component';

const routes: Routes = [{ path: '', component: StudentsComponent },
{ path: 'games', component: GameComponent  }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StudentsRoutingModule { }
