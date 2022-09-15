import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertSubmissionComponent } from './propert-submission.component';

describe('PropertSubmissionComponent', () => {
  let component: PropertSubmissionComponent;
  let fixture: ComponentFixture<PropertSubmissionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertSubmissionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertSubmissionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
