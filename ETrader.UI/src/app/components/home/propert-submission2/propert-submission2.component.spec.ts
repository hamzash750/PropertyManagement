import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertSubmission2Component } from './propert-submission2.component';

describe('PropertSubmission2Component', () => {
  let component: PropertSubmission2Component;
  let fixture: ComponentFixture<PropertSubmission2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertSubmission2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertSubmission2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
