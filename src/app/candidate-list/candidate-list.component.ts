import { Component, OnInit } from '@angular/core';
import { Candidate } from '../models/candidate';
import { CandidateService } from '../candidate/candidate.service';

@Component({
  selector: 'app-candidate-list',
  templateUrl: './candidate-list.component.html',
  styleUrls: ['./candidate-list.component.css']
})
export class CandidateListComponent implements OnInit{
  candidates: Candidate[] = [];
  
  constructor(private candidateService: CandidateService){

  }
  ngOnInit(): void {
    this.candidateService.getCandidates().subscribe(data=> this.candidates = data, error=> {
      console.log(error);

    });
  }
}
