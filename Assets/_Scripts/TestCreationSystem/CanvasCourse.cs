﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Calendar
{
    public string ics { get; set; }
}

[Serializable]
public class Enrollment
{
    public string type { get; set; }
    public string role { get; set; }
    public int role_id { get; set; }
    public int user_id { get; set; }
    public string enrollment_state { get; set; }
    public bool limit_privileges_to_course_section { get; set; }
}

[Serializable]
public class CanvasCourse
{
    public int id { get; set; }
    public int root_account_id { get; set; }
    public int account_id { get; set; }
    public string name { get; set; }
    public int enrollment_term_id { get; set; }
    public string uuid { get; set; }
    public DateTime? start_at { get; set; }
    public int? grading_standard_id { get; set; }
    public bool? is_public { get; set; }
    public DateTime created_at { get; set; }
    public string course_code { get; set; }
    public string default_view { get; set; }
    public string license { get; set; }
    public object grade_passback_setting { get; set; }
    public object end_at { get; set; }
    public bool public_syllabus { get; set; }
    public bool public_syllabus_to_auth { get; set; }
    public int storage_quota_mb { get; set; }
    public bool is_public_to_auth_users { get; set; }
    public bool homeroom_course { get; set; }
    public object course_color { get; set; }
    public object friendly_name { get; set; }
    public bool apply_assignment_group_weights { get; set; }
    public Calendar calendar { get; set; }
    public string time_zone { get; set; }
    public bool blueprint { get; set; }
    public bool template { get; set; }
    public List<Enrollment> enrollments { get; set; }
    public bool hide_final_grades { get; set; }
    public string workflow_state { get; set; }
    public bool restrict_enrollments_to_course_dates { get; set; }
    public string overridden_course_visibility { get; set; }
}
