import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VoterFormComponent } from './voter-form/voter-form.component';
import { VoterService } from './voter/voter.service';
import { VoteFormComponent } from './vote-form/vote-form.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CandidateFormComponent } from './candidate-form/candidate-form.component';
import { VoterListComponent } from './voter-list/voter-list.component';
import { CandidateListComponent } from './candidate-list/candidate-list.component';

@NgModule({
  declarations: [
    AppComponent,
    VoterFormComponent,
    VoteFormComponent,
    CandidateFormComponent,
    VoterListComponent,
    CandidateListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [VoterService],
  bootstrap: [AppComponent]
})
export class AppModule { }
