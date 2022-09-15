import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertSubmission4Component } from './propert-submission4.component';

describe('PropertSubmission4Component', () => {
  let component: PropertSubmission4Component;
  let fixture: ComponentFixture<PropertSubmission4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertSubmission4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertSubmission4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
