import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Voter } from '../models/voter';
import { Candidate } from '../models/candidate';
import { Vote } from '../models/vote';

@Injectable({
  providedIn: 'root'
})
export class VoteService {
  private url:string = "https://localhost:7206/"
  private voterUrl:string = this.url + 'Voter';
  private voteUrl: string = this.url + 'Vote';
  private candidateUrl: string = this.url + 'Candidate';

  constructor(private http: HttpClient) { }

  create(vote: Vote): Observable<Vote> {
    return this.http.post<Vote>(this.voteUrl, vote);
  }
}
