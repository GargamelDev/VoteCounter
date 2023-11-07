import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VoterFormComponent } from './voter-form.component';

describe('VouterFormComponent', () => {
  let component: VoterFormComponent;
  let fixture: ComponentFixture<VoterFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VoterFormComponent]
    });
    fixture = TestBed.createComponent(VoterFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
