import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VoteFormComponent } from './vote-form/vote-form.component';
import { VoterFormComponent } from './voter-form/voter-form.component';
import { CandidateFormComponent } from './candidate-form/candidate-form.component';
import { VoterListComponent } from './voter-list/voter-list.component';
import { CandidateListComponent } from './candidate-list/candidate-list.component';

const routes: Routes = [
  {path:"voter/new", component: VoterFormComponent},
  {path:"voter", component: VoterListComponent},
  {path:"candidate/new", component: CandidateFormComponent},
  {path:"candidate", component: CandidateListComponent},
  {path:"vote/new", component: VoteFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
